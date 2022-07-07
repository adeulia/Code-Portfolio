using System;

namespace Practice
 {
 
 class Person
    {
       //properties with auto implemneted getters/setters
        public string Name { get; set; }
        public int Age { get; set; }
        
        
        public Person(string _name, int _age)
        {
            _name = Name;
            this.Age = _age;
        }
    }
}
}
