using System;
using CandidateNamespace;

namespace TripNamespace
{
    class Trip
    {
        double budget;
        Candidate[] Candidate = new Candidate[0];

        public void cancelTrip()
        {
            Console.WriteLine("Trip cancelled");
            budget = 0;
            foreach (Candidate c in Candidate)
            {
                c.Refund = c.Contribution / 2;
                c.IsParticipating = false;
            }
        }
        public void clearCandidate()
        {
            Candidate = new Candidate[0];
        }
        public void addCandidate(Candidate c)
        {
            Array.Resize(ref Candidate, Candidate.Length + 1);
            Candidate[Candidate.Length - 1] = c;
        }
        public void deleteCandidate(string name)
        {
            for (int i = 0; i < Candidate.Length; i++)
            {
                if (Candidate[i].Name == name)
                {
                    Candidate[i] = Candidate[Candidate.Length - 1];
                    Array.Resize(ref Candidate, Candidate.Length - 1);
                    Console.WriteLine("Candidate deleted");
                    return;
                }
            }
            Console.WriteLine("Candidate not found");
        }
        public void printCandidate()
        {
            foreach (Candidate c in Candidate)
            {
                Console.WriteLine($"Name: {c.Name}, Age: {c.Age}, Contribution: {c.Contribution}, Refund: {c.Refund}, Participating: {c.IsParticipating}");
            }
        }
    }
}