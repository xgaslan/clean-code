using System;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseMailTR = new BaseMail() { Content = "Test mail", From = "Greece", To = "Turkey" };
            var baseMailEN = new BaseMail() { Content = "Test mail", From = "Turkey", To = "England" };
            
            new MailLogger().LogTurkey(baseMailTR);
            
            new MailLogger().LogEngland(baseMailEN);

            //---------------------------------
            new MailLoggerWithDI(new MailLoggerWithDI.TurkeyMailLoggerWithDI()).Log(baseMailTR);

            new MailLoggerWithDI(new MailLoggerWithDI.EnglandMailLoggerWithDI()).Log(baseMailEN);
        }
    }
}
