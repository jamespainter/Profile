using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AARC.ViewModels;
using AARC.Models;
using System.Web.Routing;

namespace AARC.Controllers
{
    public class ARCController : Controller
    {
        private ARCCDbContext db = new ARCCDbContext();
        private static string view1 = ""; 


        // GET: Login
        public ActionResult Login()
        {
            ArccView arccView = new ArccView();

            return View("Login", arccView);
        }
        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ArccView arccView)
        {
            AARCViewMethods aarcViewMethods = new AARCViewMethods();
           
            bool login =  aarcViewMethods.checkLogin(arccView); 
            if(login == true)
            {
                //  return View("ScoreProposal", arccView);
                view1 = arccView.user.Email;

                return RedirectToAction("ScoreProposal");
               // return ScoreProposal();
              //  return View("ScoreProposal", arccView);
            }
            else 
            {
                return View("Login", arccView);
            }

        }
        // GET: ARC SCORE
        public ActionResult ProposalRegistration()
        {
            ArccView arccView = new ArccView();

            return View("ProposalRegistration", arccView);

        }

        // POST: ARC SCORE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProposalRegistration(ArccView arccView)
        {

            AARCViewMethods arccViewMethods = new AARCViewMethods();
            arccViewMethods.addScore(arccView);
            // return View("Login", arccView);
            return RedirectToAction("Login");
           
        }

        // GET: ARC SCORE
        public ActionResult ScoreProposal()
        {
            
            ArccView arccView = new ArccView();
            arccView.userEmail = view1;
            //aarcViewMethods.setProposalName();
            return View("ScoreProposal", arccView);
           // return RedirectToAction("ScoreProposal"); 

        }

        // POST: ARC SCORE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScoreProposal(ArccView arccView)
        {

            AARCViewMethods userMethods = new AARCViewMethods();
            // userMethods.setProposalName(arccView);
           // TryUpdateModel(arccView);
           // userMethods.commit(arccView); 
            userMethods.insertScore(arccView);
            //return View("Login", arccView);
            return RedirectToAction("Login");
        }

        public ActionResult Registration()
        {
            ArccView arccView = new ArccView();

            //return View("Registration", arccView);
            return View(); 

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(ArccView arccView)
        {
            AARCViewMethods arccViewMethods = new AARCViewMethods();
            arccViewMethods.insertSecurityUser(arccView);
           // arccViewMethods.insertScore(arccView);
            return RedirectToAction("Login");

        }

        // GET: ARC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ARC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ARC/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ARC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ARC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ARC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ARC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
