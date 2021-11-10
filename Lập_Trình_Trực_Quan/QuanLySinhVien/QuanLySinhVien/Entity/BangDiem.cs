using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Entity
{
    class BangDiem
    {
        private int ID;
        private String classSubjectID;
        private double pointProcess;
        private double testScore;
        //private double finalGrade;


        public BangDiem() { }
        public BangDiem(int ID, String classSubjectID, float pointProcess, float testScore)
        {
            this.ID = ID;
            this.classSubjectID = classSubjectID;
            this.pointProcess = pointProcess;
            this.testScore = testScore;
            //this.finalGrade = finalGrade;

        }
        public int id { get => ID; set => ID = value; }
        public string classSid { get => classSubjectID; set => classSubjectID = value; }
        public double point { get => pointProcess; set => pointProcess = value; }
        public double score { get => testScore; set => testScore = value; }

    }
}
