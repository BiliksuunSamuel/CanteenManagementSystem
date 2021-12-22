using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenManagementSystem.Functions;
using System.Data;
using CanteenManagementSystem.Models;
namespace CanteenManagementSystem.Services
{
    internal class ClassServices
    {
        HandleException HandleException = new HandleException();

        /// <summary>
        /// FORMAT CLASS INFO
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public ClassModel FormatClassInfo(DataTable dt)
        {
            try
            {
                ClassModel model= new ClassModel();
                foreach (DataRow row in dt.Rows)
                {
                    model.ClassID = row["ClassID"].ToString();
                    model.ClassTitle = row["ClassTitle"].ToString();
                }
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// VALIDATE CLASS INFO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ClassModel ValidateClassInfo(ClassModel model)
        {
            try
            {
                if (model.ClassTitle.Length <= 0)
                {
                    throw HandleException.HandleStack(message: "Class Title Required ***", source: "Class Info Validation");

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
        /// GENERATE CLASS ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ClassModel GenerateClassID(ClassModel model)
        {
            try
            {
                Random rand = new Random();
                model.ClassID = "CID" + rand.Next(10, 99).ToString();
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
