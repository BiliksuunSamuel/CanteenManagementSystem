using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Functions;
namespace CanteenManagementSystem.Services
{
    internal class StudentsServices
    {
        HandleException handleEx = new HandleException();

        /// <summary>
        /// FORMAT STUDENT INFO
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public StudentsModel FormatStudentInfo(DataTable dt)
        {
            StudentsModel model = new StudentsModel();
            foreach (DataRow row in dt.Rows)
            {
                model.StudentName = row["StudentName"].ToString();
                model.Contact = row["Contact"].ToString();
                model.StudentID = row["StudentID"].ToString();
                model.ClassID = row["ClassID"].ToString();
                model.Gender = row["Gender"].ToString();
            }

            return model;
        }

        /// <summary>
        /// VALIDATE STUDENT INFO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public StudentsModel ValidateStudentInfo(StudentsModel model)
        {
            try
            {
                long phone = 0;

                if (model.StudentName.Length <= 0)
                {
                    throw handleEx.HandleStack("Student Name Required", "Student Info Validation");
                }
                if(!long.TryParse(model.Contact,out phone)||model.Contact.Length!=10)
                {
                    throw handleEx.HandleStack("Invalid Phone Number", "Student Info Validation");

                }

                if (model.Gender.Length <= 0)
                {
                    throw handleEx.HandleStack("Student Gender Required", "Student Info Validation");
                }
                model.valid = true;
                model.error = "";
                return model;

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GENERATE STUDENT ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public StudentsModel GenerateStudentID(StudentsModel model)
        {
            try
            {
                var names = model.StudentName.Split(' ');
                foreach (string name in names)
                {
                    char [] chars = name.ToCharArray();
                    model.StudentID = model.StudentID + chars[0].ToString().ToUpper();
                }
                Random ran = new Random();
                model.StudentID = model.StudentID + ran.Next(10, 1000);
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// FILTER STUDENT INFO FROM DATA ROW
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public StudentsModel FilterRowInfo(DataRow row)
        {
            try
            {
                StudentsModel model = new StudentsModel();
                model.StudentName = row["StudentName"].ToString();
                model.ClassID = row["ClassID"].ToString();
                model.Contact = row["Contact"].ToString();
                model.Gender = row["Gender"].ToString();
                model.StudentID = row["StudentID"].ToString();

                return model;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public StudentsModel FilterRowViewInfo(DataRow row)
        {
            try
            {
                StudentsModel model = new StudentsModel();
                model.StudentName = row["Name"].ToString();
                model.ClassID = row["Class"].ToString();
                model.Contact = row["Contact"].ToString();
                model.Gender = row["Gender"].ToString();
                return model;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
