using System;

namespace ShapeProject
{
    //abstract, to be used by others not by itself
    public abstract class Shape
    {
        //the base class and all of its derived classes can access the property
        protected Shape(string name)
        {
            Name = name;
        }
        public string Name { get; }

        //indicating that derived classes can override this
        public virtual string GetName()
        {
            return "Shape: " + Name;
        }


        public abstract double GetArea();

    }
}
