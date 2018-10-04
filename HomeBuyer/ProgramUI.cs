using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuyer
{
    class ProgramUI
    {
        
            private BuyerRepository _buyerRepo = new BuyerRepository();
            private AgentRepository _agentRepo = new AgentRepository();

            public void Run()
            {
                SetUpGame();
                RunGame();
               // End Game();
            }

            private void SetUpGame()
            {
                CreateBuyer();
                CreateAgent();
                ShowBuyerDetails();
                ShowAgentDetails();
            }

            private void CreateBuyer()
            {
                Console.WriteLine("Hello Future Homeowner! What is your name?");

                string name = Console.ReadLine();

                _buyerRepo.CreateBuyer(name);
            }

            private void CreateAgent()
            {
                Console.WriteLine("What is your agent's name?");

                string name = Console.ReadLine();

                _agentRepo.CreateAgent(name);
            }

            private void ShowBuyerDetails()
            {
                Console.WriteLine("Here are your buyer details:\n");

                var buyer = _buyerRepo.BuyerDetails();

                Console.WriteLine($"Buyer Details {buyer.Name}" +
                    $"budget : {buyer.Budget}");

                Console.ReadLine();
            }

            private void ShowAgentDetails()
            {
                Console.WriteLine("Here are the details for your Agent:\n");

                var agent = _agentRepo.AgentDetails();

                Console.WriteLine($"Agent Details {agent.Name}" +
                    $"credibility: {agent.Credibility}");

                 Console.ReadLine();
            }

             public void RunGame()
             {
                 var buyer = _buyerRepo.BuyerDetails();
                 var agent = _agentRepo.AgentDetails();

                 while (buyer.HasMoney && agent.IsCredible)
                 {
                    PromptPlayer();
                 }
             }

            private void PromptPlayer()
            {
                var agent = _agentRepo.AgentDetails();
                Console.WriteLine($"{agent.Name} has found a home for you that is in your budget. What would you like to :" +
                     "1. Tour Home" +
                     "2. Pass on Home");

                 var input = int.Parse(Console.ReadLine());

                 HandleBuyerInput(input);
            }

            private void HandleBuyerInput(int input)
            {
                switch(input)
                {
                    case 1:
                    Tour();
                    break;

                    case 2:
                    Pass();
                    break;
    
                }
            }

            private void Tour()
            {
                //get buyer variable 
                var buyer = _buyerRepo.BuyerDetails();
                var agent = _agentRepo.AgentDetails();

                //get agent credibility
                 _agentRepo.Tour(agent.Credibility);
                 _buyerRepo.Tour(buyer.Budget);

                //get the new credibility points of agent
                Console.WriteLine($"{agent.Name}'s crediblity points are {agent.Credibility} and { buyer.Name}'s budget is {buyer.Budget}");
            }

             private void Pass()
            {
                //get buyer variable 
                 var buyer = _buyerRepo.BuyerDetails();
                 var agent = _agentRepo.AgentDetails();

                //get agent budget
                 _agentRepo.Pass(agent.Credibility);
   

                //get the new credibility points of agent
                 Console.WriteLine($"{agent.Name}'s crediblity points are {agent.Credibility} and {buyer.Name}'s budget is {buyer.Budget}");
             }

            private void EndGame()
            {
                var agent = _agentRepo.AgentDetails();
                var buyer = _buyerRepo.BuyerDetails();
                Console.WriteLine($"{agent.Name} has lost her creidibility with {buyer.Name}. Maybe you should find another agent?");
            }

    }
}

