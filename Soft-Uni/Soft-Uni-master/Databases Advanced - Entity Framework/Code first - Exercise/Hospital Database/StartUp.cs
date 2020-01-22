using System;
using P01_HospitalDatabase.Data.Models;
using P01_HospitalDatabase.Data;
using Microsoft.EntityFrameworkCore;

namespace P01_HospitalDatabase 
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new HospitalDBContext();
            context.Database.EnsureCreated();
            
        }
    }
}
