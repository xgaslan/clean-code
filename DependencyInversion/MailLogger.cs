using System;

namespace DependencyInversion
{
    public class MailLogger
    {
        public void LogTurkey(BaseMail mail)
        {
            new TurkeyMailLogger().Log(mail);
        }

        public void LogEngland(BaseMail mail)
        {
            new EnglandMailLogger().Log(mail);
        }
    }

    public class TurkeyMailLogger
    {
        public void Log(BaseMail mail)
        {
            Console.WriteLine(mail);
        }
    }

    public class EnglandMailLogger
    {
        public void Log(BaseMail mail)
        {
            Console.WriteLine(mail);
        }
    }
}