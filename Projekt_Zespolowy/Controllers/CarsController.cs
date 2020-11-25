using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Projekt_Zespolowy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CarsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //////////////////////////////
        ///

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    select * from dbo.Cars";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CarServicesAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }
    }
}
