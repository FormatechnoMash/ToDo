// See https://aka.ms/new-console-template for more information

#region public
string m_choixMenu;
int m_choixMenuIndex = 4;
bool m_succes=false;
Task m_task = new Task();
List<Task> m_list = new List<Task>();
#endregion

#region Fonctions
static Task createTask()
{
    Task task = new Task();
    return task;
}

void modifyTask()
{
    string choixMenu;
    string modification;
    int choixMenuIndex=4;
    int choixNumeroModifier=0;
    bool succes=false;
    while (succes != true)
    { 
    Console.WriteLine("----Que voulez vous modifier?----");
    Console.WriteLine("1. Le nom d'une tache");
    Console.WriteLine("2. La description d'une tache");
    Console.WriteLine("3. Le status d'une tache");
    Console.WriteLine("4. Quitter");
    choixMenu=Console.ReadLine();
    succes =int.TryParse(choixMenu, out choixMenuIndex); 
    }
    switch (choixMenuIndex)
    {
        case 1:
            for (int i = 0; i < m_list.Count; i++)
            {
                Console.WriteLine(i+ ". "+ m_list[i]._taskName);
            }
            while (succes != true)
            { 
                Console.WriteLine("Donnez moi le numéro de la tache que vous voulez modifier."); 
                choixMenu=Console.ReadLine();
                succes =int.TryParse(choixMenu, out choixNumeroModifier); 
            }
            Console.WriteLine("Quel nom voulez vous lui donner?");
            modification = Console.ReadLine();
            m_list[choixNumeroModifier]._taskName = modification;
            
            break;
        case 2:
            for (int i = 0; i < m_list.Count; i++)
            {
                Console.WriteLine(i+ ". "+ m_list[i]._taskDescription);
            }
            while (succes != true)
            { 
                Console.WriteLine("Donnez moi le numéro de la tache que vous voulez modifier."); 
                choixMenu=Console.ReadLine();
                succes =int.TryParse(choixMenu, out choixNumeroModifier); 
            }
            Console.WriteLine("Quelle description voulez vous lui donner?");
            modification = Console.ReadLine();
            m_list[choixNumeroModifier]._taskDescription = modification;
            break;
        case 3:
            for (int i = 0; i < m_list.Count; i++)
            {
                Console.WriteLine(i+ ". "+ m_list[i]._taskName);
                Console.WriteLine(" |"+ m_list[i]._myState);
            }
            while (succes != true)
            { 
                Console.WriteLine("Donnez moi le numéro de la tache que vous voulez modifier."); 
                choixMenu=Console.ReadLine();
                succes =int.TryParse(choixMenu, out choixNumeroModifier); 
            }
            while (succes != true)
            { 
            Console.WriteLine("Quel status voulez vous lui donner?");
            Console.WriteLine("0. ToDo");
            Console.WriteLine("1. InProgress");
            Console.WriteLine("2. Done");
            choixMenu= Console.ReadLine();
            succes =int.TryParse(choixMenu, out choixNumeroModifier); 
            }
            break;
        case 4:
            Console.WriteLine("Aurevoir");
            break;
        default:
            Console.WriteLine("Une erreur est survenue");
            break;
        
    }
    
}

void modifyTaskStatus()
{
    
}

void consultTask()
{
    
}
#endregion


#region Main

while (true)
{
 
    Console.WriteLine("----Que voulez vous faire?----");
    Console.WriteLine("1. Créer une tache");
    Console.WriteLine("2. Modifier une tache");
    Console.WriteLine("3. Consulter mes taches");
    Console.WriteLine("4. Quitter");
    m_choixMenu=Console.ReadLine();
    while (m_succes != true)
    { 
        m_succes =int.TryParse(m_choixMenu, out m_choixMenuIndex); 
    }

    switch (m_choixMenuIndex)
    {
        case 1:
            m_task=createTask();
            Console.WriteLine("Quel nom voulez vous donner a votre tache?");
            string temp =Console.ReadLine();
            m_task._taskName= temp;
            Console.WriteLine("Quel est la description de votre tache?");
            temp=Console.ReadLine();
            m_task._taskDescription = temp;
            m_list.Add(m_task);
            break;
        case 2:
            modifyTask();
            break;
        case 3:
            consultTask();
            break;
        case 4:
            Console.WriteLine("Aurevoir");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Une erreur est survenue");
            break;
        
    }
    
}

#endregion

#region Classes
public class Task
{
  
    public string _taskName { get; set; }
    public string _taskDescription { get; set; }
    public State _myState ;
    public Task()
    {
        _myState = State.ToDo;
    }
}

public class taskManager
{
    
}

#endregion

#region Enumerations

public enum State
{
    ToDo,
    InProgress,
    Done
}

#endregion

#region private

#endregion