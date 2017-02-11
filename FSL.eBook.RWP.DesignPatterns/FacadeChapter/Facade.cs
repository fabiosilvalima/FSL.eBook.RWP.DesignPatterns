using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.FacadeChapter
{
    public class Facade
    {
        private Logger _logger;
        private Payment _payment;
        private SecurityInfo _securityInfo;
        private Trasaction _transaction;

        public Facade()
        {
            _logger = new Logger();
            _payment = new Payment();
            _securityInfo = new SecurityInfo();
            _transaction = new Trasaction();
        }

        public bool Pay(string userId, double amount)
        {
            _logger.Log("Payment Start");
            var result = false;
            var securityId = _securityInfo.GetFromUserId(userId);
            _logger.Log($"Security id {securityId} for user id {userId}");
            _transaction.Start();
            _transaction.Do(() =>
            {
                result = _payment.Pay(securityId, amount);
                _logger.Log($"Paying {amount} for security id {securityId}");
            });
            _transaction.End();
            _logger.Log("transaction end");
            _logger.Log($"payment result {result}");
            _payment.Dispose();
            _transaction.Dispose();
            _securityInfo.Dispose();
            _logger.Dispose();

            return result;
        }
    }
}