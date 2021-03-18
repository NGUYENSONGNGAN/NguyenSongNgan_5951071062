using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NGUYENSONGNGAN_5951071062.Models;

namespace NGUYENSONGNGAN_5951071062.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInList = new List<StudentInfo>();

            var StudentInfo = new StudentInfo
            {
                HoVaTen = "Nguyn Song Ngan",
                MSV = "5951071062",
                LopHoc = "CQ.CNTT.K59"

            };

            StudentInList.Add(StudentInfo);
            return StudentInList;

        }
    }
}
