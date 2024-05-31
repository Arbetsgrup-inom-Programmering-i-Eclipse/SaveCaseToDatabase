using System;
using System.Linq;
using System.Text;
using System.Reflection;
using VMS.TPS.Common.Model.API;
using System.IO;
using System.Data;
using System.Windows;
using System.Xml;
using System.Xml.Linq;


// TODO: Replace the following version attributes by creating AssemblyInfo.cs. You can do this in the properties of the Visual Studio project.
[assembly: AssemblyVersion("1.0.0.1")]
[assembly: AssemblyFileVersion("1.0.0.1")]
[assembly: AssemblyInformationalVersion("1.0")]

// TODO: Uncomment the following line if the script requires write access.
[assembly: ESAPIScript(IsWriteable = false)]

namespace VMS.TPS
{
    public class Script
    {
        public void Execute(ScriptContext context)
        {

            try
            {
                Patient patient = context.Patient;

                if (patient != null)
                {

                    Form.InputForm PopUp = new Form.InputForm(context);
                    PopUp.ShowDialog();

                    if(PopUp.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {

                        string path = @"PATH_TO_FOLDER_TO_SAVE_DATABASE_FILEN\ExportDB.xml";


                        if (!File.Exists(@path))
                        {
                            Stream xmlFile = new FileStream(@path, FileMode.Append);
                            XmlTextWriter textWritter = new XmlTextWriter(xmlFile, Encoding.Default);
                            textWritter.WriteStartDocument();
                            textWritter.WriteStartElement("DB");
                            textWritter.WriteEndElement();
                            textWritter.WriteEndDocument();
                            textWritter.Close();
                        }

                        XDocument doc = XDocument.Load(@path);
                        XElement db = doc.Element("DB");

                        var PatSer = GetPatientSer(patient.Id);

                        int CaseNumber;

                        if(db.Elements().LastOrDefault() == null) //Hitta vilket nummer/id nya fallet ska ha i databasen 
                        {
                            CaseNumber = 1;
                        }
                        else
                        {
                            CaseNumber = Convert.ToInt32(db.Elements().Last().Element("CaseNumber").Value) + 1;
                        }

                        string Plan;
                        RTPrescription prescription;
                        string Ordination;

                        if (PopUp.Plan_index == -1) //om ingen plan har valts, hitta ordinationen i Aria databasen
                        {
                            Plan = "None";
                            prescription = patient.Courses.ElementAt(PopUp.Course_Index).TreatmentPhases.Where(x => x.Prescriptions.FirstOrDefault() != null && x.Prescriptions.Where(y => y.Status == "Approved").FirstOrDefault() != null).First().Prescriptions.Where(x => x.Status == "Approved").FirstOrDefault();
                            if (prescription != null)
                            {
                                Ordination = prescription.Targets.First().DosePerFraction + " x " + prescription.Targets.First().NumberOfFractions; // Antar att f�rsta target i ordinationen �r huvudtarget
                            }
                            else
                            {
                                Ordination = "None";
                            }
                        }
                        else //om en plan har valts, ta dos per fx och slutdos fr�n planen i Eclipse
                        {
                            Plan = patient.Courses.ElementAt(PopUp.Course_Index).PlanSetups.ElementAt(PopUp.Plan_index).Id;
                            Ordination = patient.Courses.ElementAt(PopUp.Course_Index).PlanSetups.ElementAt(PopUp.Plan_index).DosePerFraction + " x " + patient.Courses.ElementAt(PopUp.Course_Index).PlanSetups.ElementAt(PopUp.Plan_index).NumberOfFractions;
                        }


                        db.Add(new XElement("NewCase",
                                   new XElement("CaseNumber", CaseNumber.ToString()),
                                   new XElement("Kategori", PopUp.Category),
                                   new XElement("Sub-Kategori", PopUp.Sub_Category),
                                   new XElement("Ordination", Ordination),
                                   new XElement("AriaUser", context.CurrentUser.Id.Substring(9)),
                                   new XElement("PatientSer", PatSer),
                                   new XElement("Course", patient.Courses.ElementAt(PopUp.Course_Index).Id),
                                   new XElement("Plan", Plan),
                                   new XElement("Datum", DateTime.Today.ToString("dd-MMM-yy")),
                                   new XElement("Kommentar", PopUp.Comment)
                                   ));
                        doc.Save(@path);

                        //doc = XDocument.Load(@pathBackUp);
                        //db = doc.Element("DB");
                        //db.Add(new XElement("NewCase",
                        //           new XElement("CaseNumber", CaseNumber.ToString()),
                        //           new XElement("Kategori", PopUp.Category),
                        //           new XElement("Sub-Kategori", PopUp.Sub_Category),
                        //           new XElement("Ordination", Ordination),
                        //           new XElement("AriaUser", context.CurrentUser.Id.Substring(9)),
                        //           new XElement("PatientSer", PatSer),
                        //           new XElement("Course", patient.Courses.ElementAt(PopUp.Course_Index).Id),
                        //           new XElement("Plan", Plan),
                        //           new XElement("Datum", DateTime.Today),
                        //           new XElement("Kommentar", PopUp.Comment)
                        //           ));
                        //doc.Save(@pathBackUp);

                        MessageBox.Show("Sparat!");
                    } 
                }
                else
                {
                    MessageBox.Show("�ppna en patient innan du k�r scriptet");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Kunde inte spara fallet\r\n" + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }


        static private string GetPatientSer(string patientID)
        {
            (DataTable datatable, Exception exception) = AriaInterface.Query(AriaDatabase.Clinical, @"SELECT 
	                                                        Patient.PatientSer
                                                        FROM 
	                                                        Patient
                                                        WHERE 		           
                                                            Patient.PatientId LIKE @patientID 
                                                        GROUP BY
                                                            Patient.PatientSer", ("patientID", patientID));
            if (!datatable.Rows[0].IsNull(0)) return datatable.Rows[0]["PatientSer"].ToString();
            return string.Empty;
        }
    }
}
