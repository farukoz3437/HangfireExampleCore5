using Hangfire;
using HangFireCore5.Contexts;
using HangFireCore5.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace HangFireCore5.Hangfire
{
    public class Hangfire:IHangfire
    {
        public HangfireContext _context { get; set; }
        public Hangfire(HangfireContext context)
        {
            _context = context;
        }
        public bool CreateNumber()
        {
            try
            {

                RecurringJob.AddOrUpdate(() => Deneme(),
                Cron.Minutely);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Deneme()
        {
            Number number = new Number();
            Random rd = new Random();
            number.NewNumber = rd.Next(100, 200);
            _context.Add(number);
            _context.SaveChanges();
        }

    }
}
