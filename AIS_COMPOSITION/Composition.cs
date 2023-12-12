using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_COMPOSITION
{
    public interface IComponent
    {
        bool AddComponent(Component component);
        bool RemoveComponent(Component component);
        string Display();
    }

    public abstract class Component : IComponent
    {
        public string name { get; set; }
        

        public Menu parrent { get; set; }

        public Component(string name)
        {
            this.name = name;
        }


        public Component() { }

        public abstract bool AddComponent(Component component);
        public abstract bool RemoveComponent(Component component);
        public abstract string Display();
    }

    public class Menu : Component
    {
        public List<Component> children= new List<Component>();

        public Menu(string name)
            : base(name) {}

        public Menu(){}
       

        public override bool AddComponent(Component component)
        {
            children.Add(component);
            component.parrent=this;

            return true;
        }

        public override bool RemoveComponent(Component component)
        {
            children.Remove(component);

            return true;
        }

        public override string Display()
        {
            return null;
        }
    }

    public class Book : Component
    {
        protected string description;

        public Book(string name, string description)
            : base(name) 
        {
            this.description = description;
        }

        public override bool AddComponent(Component component)
        {
            return false;
        }

        public override bool RemoveComponent(Component component)
        {
            return false;
        }

        public override string Display()
        {
            return $"{name}\n" +
                $"\n{description}";
        }
    }
}
