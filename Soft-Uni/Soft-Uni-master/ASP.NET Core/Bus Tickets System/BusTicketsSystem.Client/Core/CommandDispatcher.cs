using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusTicketsSystem.Client.Core.Commands.Contracts;
using System.Reflection;

namespace BusTicketsSystem.Client.Core
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public string DispatchCommand(string[] commandParameters)
        {
            string commandName = commandParameters[0];
            string[] commandTokens = commandParameters.Skip(1).ToArray();
            ICommand command = null;
            string result = null;

            try
            {
                command = GetCommand(commandName);
                result = command.Execute(commandTokens);
            }
            catch (Exception e)
            {

                if (e is NullReferenceException || e is IndexOutOfRangeException)
                {
                    throw new InvalidOperationException($"Command {commandName} is not valid!");
                }
                throw e;
            }

            return result;
        }

        private ICommand GetCommand(string commandName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var commandTypes = assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(ICommand))).ToArray();
            var commandType = commandTypes.SingleOrDefault(t => t.Name == $"{commandName}Command");

            var constructor = commandType.GetConstructors().First();
            var constructorParameters = constructor.GetParameters().Select(p => p.ParameterType).ToArray();
            var services = constructorParameters.Select(x => serviceProvider.GetService(x)).ToArray();
            var command = (ICommand)constructor.Invoke(services);

            return command;
        }
    }
}
