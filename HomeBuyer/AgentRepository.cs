using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuyer
{
    class AgentRepository
    {
        //private Agent _agent = new Agent();
        private Agent _agent;

        public void CreateAgent(string name)
        {
            _agent = new Agent
            {
                Name = name,
                TourPower = 10,
                PassDamage= 10,
                Credibility = 30,
                IsCredible = true
            };
        }

        public Agent AgentDetails()
        {
            return _agent;
        }

        public void Tour(int tourPower)
        {
            _agent.Credibility += tourPower;
        }

        public void Pass(int passDamage)
        {
            _agent.Credibility -= passDamage;
        }

        public void EndGame()
        {
            _agent.Credibility = 0;
        }
    }
}
