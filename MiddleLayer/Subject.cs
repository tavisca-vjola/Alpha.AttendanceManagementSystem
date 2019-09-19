﻿using AMS.MiddleLayer.Personna;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.MiddleLayer
{
    public class Subject
    {
        private Dictionary<int, int> _studentAttendance = new Dictionary<int, int>();


        public string Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public int TotalAttendance { get; set; }

    
        /// <summary>
        ///this dictionary is mapping studentid to their attendance
        /// </summary>
        /// <returns></returns>
        public ref Dictionary<int, int> GetEnrolledStudents()
        {
            return  ref _studentAttendance;
        }
    }
}
