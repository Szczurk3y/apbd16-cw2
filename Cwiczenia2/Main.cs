using Cwiczenia2.Classes;
using IContainer = Cwiczenia2.Interfaces.IContainer;

namespace Cwiczenia2;
public class Cwiczenia2
{
    static List<ContainerShip> containerShips = new List<ContainerShip>();
    static List<IContainer> containers = new List<IContainer>();
    public static void Main(string[] args)
    {
        ActionType currentAction = ActionType.MENU;

        while (true)
        {
                        
            switch (currentAction)
            {
                case ActionType.ADD_CONTAINERSHIP:
                {
                    
                    break;
                }
                case ActionType.ADD_CONTAINER:
                {
                    
                    break;
                }
                case ActionType.REMOVE_CONTAINERSHIP:
                {
                    
                    break;
                }
                case ActionType.REMOVE_CONTAINER:
                {
                    
                    break;
                }
                case ActionType.MENU:
                {
                    currentAction = (ActionType)ShowMenu();
                    break;
                }
            }
        }   
    }

    private static int ShowMenu()
    {
        Console.WriteLine("Lista kontenerowców: ");
        if (containerShips.Count > 0)
        {
            foreach (var containerShip in containerShips.Select((v, i) => new { Container = v, Index = ++i }))
            {
                Console.Write("Statek " + containerShip.Index + " " + containerShip.Container.GetContainerShipInfo());
            }
        }
        else Console.WriteLine("Brak");
                    
        Console.WriteLine("Lista kontenerów: ");
        if (containers.Count > 0)
        {
            foreach (var container in containers.Select((v, i) => new { Container = v, Index = ++i }))
            {
                Console.Write("Kontener  " + container.Index + " (" + container.Container.GetSerialNumber() + ")");
            }
        } else Console.WriteLine("Brak");
                    
        Console.WriteLine("Możliwe akcje:");
        Console.WriteLine("1. Dodaj kontenerowiec");
        if (containerShips.Count > 0)
        {
            Console.WriteLine("2. Usuń kontenerowiec");
            Console.WriteLine("3. Dodaj kontener");
        }

        if (containers.Count > 0)
        {
            Console.WriteLine("4. Usuń kontener");
        }

        int number;
        do
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                if (number is > 0 and < 5) return number;
            }
            else Console.Write("That's not a valid number!");
        } while (number is < 1 or > 4);

        return 0;
    }
}

public enum ActionType
{
    ADD_CONTAINERSHIP = 1,
    REMOVE_CONTAINERSHIP = 2,
    ADD_CONTAINER = 3,
    REMOVE_CONTAINER = 4,
    MENU
}