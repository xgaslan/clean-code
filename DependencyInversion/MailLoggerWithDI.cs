using System;

namespace DependencyInversion
{
    public class MailLoggerWithDI
    {
        private readonly ILogger _logger;

        public MailLoggerWithDI(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(BaseMail mail)
        {
            _logger.MailLog(mail);
        }

        public class TurkeyMailLoggerWithDI : ILogger
        {
            public void MailLog(BaseMail mail)
            {
                throw new NotImplementedException();
            }
        }

        public class EnglandMailLoggerWithDI : ILogger
        {
            public void MailLog(BaseMail mail)
            {
                throw new NotImplementedException();
            }
        }
    }
}