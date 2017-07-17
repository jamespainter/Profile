namespace AARC.ViewModels
{


    

    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using AARC.Models;
    using System.Web.Mvc;
    using System.Data.SqlClient;

   
   
   


    public class ARCCRepository 
    {
        
    }
    public class ArccView
    {
       
        public ArccView()
        {
            this.user = new SECURITY();
            this.userEmail = ""; 
            this.scores = new List<SCORE>();
            this.score = new SCORE();
            this.vm = new AARCViewMethods();
            vm.getAllProposals(this);
            this.userEmail = vm.getUserEmail(this);

        }
        public SECURITY user { get; set; }
        public List<SCORE> scores { get; set; }

        public string userEmail { get; set;  }

        public SCORE score { get; set; }
        public AARCViewMethods vm { get; set; }

       

        public void dummyData(ArccView arccView)
        {
            arccView.user.FirstName = "Kaiya";
            arccView.user.LastName = "Login";
            arccView.user.Email = "JamesPainter@mail.weber.edu";
            arccView.user.Password = "1234";
            arccView.scores[0].Proposal_Name = "Rague";
            arccView.scores[0].Education_Exp = 0;
            arccView.scores[0].Innovation = 1;
            arccView.scores[0].Dissemination = 2;
            arccView.scores[0].Evaluation = 3;
            arccView.scores[0].Support = 4; 
            
        }
    }
    public class AARCViewMethods
    {
      
      // private ArccView userEmailreturn = new ArccView(); 
        public void insertSecurityUser(ArccView arccView)
        {
            ARCCDbContext db = new ARCCDbContext();
            db.securityDB.Add(arccView.user);
            db.SaveChanges(); 
            insertScore(arccView); 


        }
        public void insertScore(ArccView arccView)
        {
            ARCCDbContext db = new ARCCDbContext();
            SCORE arccView2 = new SCORE();
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [SCORE]");
            
            for (int i = 0; i < arccView.scores.Count; i++)
            { 
                
                    if (arccView.scores[i].Proposal_Name != null)
                    {
                        
                         db.scoreDB.Add(arccView.scores[i]);
                         
                    }
                    
            }
            db.SaveChanges();

        }
        public void addScore(ArccView arccView)
        {
            ARCCDbContext db = new ARCCDbContext();

            
                db.scoreDB.Add(arccView.score);
                db.SaveChanges();
        }
        public bool checkLogin(ArccView arccView)
        {
            ARCCDbContext db = new ARCCDbContext();
            SECURITY user = db.securityDB.Where(u => u.Email.Equals(arccView.user.Email) && u.Password.Equals(arccView.user.Password)).FirstOrDefault();
           
            if(user != null)
            {
                 
                return true; 
            }
            else
            {
                return false; 
            }

        }

        public void setProposalName(ArccView arccView)
        {
            ARCCDbContext db = new ARCCDbContext();
            SECURITY user = db.securityDB.Where(u => u.Email.Equals(arccView.user.Email) && u.Password.Equals(arccView.user.Password)).FirstOrDefault();
            for(int i = 0; i < arccView.scores.Count; i++)
            { 
                arccView.scores[i].Proposal_Name = user.LastName;
            }
        }

        public string getUserEmail(ArccView arccView)
        {
            
            return arccView.userEmail.ToString();
        }
      
        public void commit(ArccView arccView)
        {
            ARCCDbContext db = new ARCCDbContext();
            db.SaveChanges(); 
        }

      

        public void getAllProposals(ArccView arccView)
        {

            //  var scores = db.scoreDB.Select(u => new { u.Proposal_Name, u.Education_Exp, u.Innovation, u.Dissemination, u.Evaluation, u.Support }).AsEnumerable();
            ARCCDbContext db = new ARCCDbContext();
            List<SCORE> scoreDatabase = db.scoreDB.ToList(); 
            arccView.scores = scoreDatabase; 
            
        }
        //public void addProposalsToScores(ArccView arccView)
        //{
        //    for (int i = 0; i < 5; i++)
        //    { 
        //        arccView.scores[i].Proposal_Name = arccView.ProposalName[i];
        //        arccView.scores[i].Education_Exp = arccView.Educational_Exp[i];
        //        arccView.scores[i].Innovation = arccView.Innovation[i];
        //        arccView.scores[i].Dissemination = arccView.Dissemination[i];
        //        arccView.scores[i].Evaluation = arccView.Evaluation[i];
        //        arccView.scores[i].Support = arccView.Support[i];
        //    }
        //}
           
           


        


    }
}