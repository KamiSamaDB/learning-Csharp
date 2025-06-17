using System;

namespace CandidateNamespace
{
    class Candidate
    {
        string name;
        int age;
        double contribution;
        double refund = 0;
        bool isParticipating;

        public Candidate(string name, int age, double contribution, bool isParticipating)
        {
            this.name = name;
            this.age = age;
            this.contribution = contribution;
            this.isParticipating = isParticipating;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Contribution
        {
            get { return contribution; }
            set { contribution = value; }
        }

        public double Refund
        {
            get { return refund; }
            set { refund = value; }
        }

        public bool IsParticipating
        {
            get { return isParticipating; }
            set { isParticipating = value; }
        }
    }
}