using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eatm.Models;

namespace Eatm.Controllers
{
    public class TransactionController : Controller
    {
        private ApplicationDbContext _context;

        public TransactionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CheakLogin(Bankac formdata)
        {
            var account = _context.Bankac.SingleOrDefault(c => c.CardNo == formdata.CardNo && c.PIN == formdata.PIN);

            if (account == null)
                return RedirectToAction("Login");
            return RedirectToAction("Options", new{id = account.Id});
        }

        [Route("transaction/{id}/options")]
        public ActionResult Options(int id)
        {
            var account = _context.Bankac.SingleOrDefault(c => c.Id == id);

            if (account == null)
                return RedirectToAction("Login");
            return View(account);
        }

        [Route("transaction/{id}/balanceCheck")]
        public ActionResult BalanceCheck(int id)
        {
            var account = _context.Bankac.SingleOrDefault(c => c.Id == id);

            if (account == null)
                return RedirectToAction("Login");
            return View(account);
        }

        [Route("transaction/{id}/withdrawal")]
        public ActionResult Withdrawal(int id)
        {
            var account = _context.Bankac.SingleOrDefault(c => c.Id == id);

            if (account == null)
                return RedirectToAction("Login");
            return View(account);
        }

        [Route("transaction/{id}/deposit")]
        public ActionResult Deposit(int id)
        {
            var account = _context.Bankac.SingleOrDefault(c => c.Id == id);

            if (account == null)
                return RedirectToAction("Login");
            return View(account);
        }

        [HttpPost]
        public ActionResult DoWithdrawal(int id, double amount)
        {
            var account = _context.Bankac.SingleOrDefault(c => c.Id == id);
            if (account == null)
                return RedirectToAction("Login");

            if (account.Balance > amount)
            {
                account.Balance = account.Balance - amount;
                _context.SaveChanges();
            }
            else
            {
                Response.Write("insufficient Balance");
                return RedirectToAction("Withdrawal");
            }

            return RedirectToAction("BalanceCheck");
        }

        [HttpPost]
        public ActionResult DoDeposit(int id, double amount)
        {
            var account = _context.Bankac.SingleOrDefault(c => c.Id == id);
            if (account == null)
                return RedirectToAction("Login");

            account.Balance = account.Balance + amount;
            _context.SaveChanges();

            return RedirectToAction("BalanceCheck");
        }
    }
}