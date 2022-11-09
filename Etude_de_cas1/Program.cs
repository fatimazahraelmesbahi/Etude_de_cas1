using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas1
{
    class Examen
    {
        public string NomExam { get; set; } = "Exam";
        public DateTime Duré { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Enonce { get; set; }
        public Examen(string nomexam, DateTime duré, DateTime datedebut, DateTime datefin )
        {
            this.NomExam = nomexam;
            this.Duré = duré;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
        }

        public Examen(string enonce)
        {
            this.Enonce = enonce;
        }
    }

    class Question : Examen
    {
        public string Enoncé { get; set; }
        public int Notequestion { get; set; }
        public Question(string enonce, int notequestion) : base(enonce)
        {
            this.Notequestion = notequestion;
        }

        public Question(string enonce) : base(enonce)
        {
        }
    }
    class Qcm : Question
    {
        public float Certitude { get; set; } = 0;
        public Qcm(float certitude ,string enonce) : base(enonce)
        {
            this.Certitude=certitude;
        }
    }
    class Q_dechotomique : Question
    {
        public string Alternative { get; set; }
        public int Binaire { get; set; } = 0;
        public Q_dechotomique(string alternative, int binaire, string enonce) : base(enonce)
        {
            this.Alternative = alternative;
            this.Binaire = binaire;
        }
    }
    class Q_ouverte : Question
    {

        public Q_ouverte(string enonce) : base (enonce){ }
        
    }
    class Proposition : Examen
    {
        public string Typeprop { get; set; }
        public Proposition(string typeprop, string enonce) : base(enonce)
        {
            this.Typeprop = typeprop;
        }

        public Proposition(string enonce) : base(enonce)
        {
        }
    }
    class Rep_choix : Proposition
    {
        public bool Rep_vrai { get; set; }
        public bool Rep_fausse { get; set; }
        public Rep_choix(bool rep_vrai, bool rep_fausse, string enonce) : base(enonce)
        {
            this.Rep_vrai = rep_vrai;
            this.Rep_fausse = rep_fausse;
        }
    }
    class Rep_ouverte : Proposition
    {
        
        public Rep_ouverte(string enonce) : base(enonce)
        {
        }
    }
    class Mauvaise_rep : Proposition
    {

        public Mauvaise_rep(string enonce) : base(enonce)
        {
        }
    }
    class Pénabilité : Mauvaise_rep
    {

        public Pénabilité(string enonce) : base(enonce: enonce)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
