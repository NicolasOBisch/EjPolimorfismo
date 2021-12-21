// See https://aka.ms/new-console-template for more information
class Animal  
{
  public virtual void animalS() 
  {
    Console.WriteLine("Los animales hacen un sonido");
  }
}

class Gato : Animal   
{
  public override void animalS() 
  {
    Console.WriteLine("El gato hace: miau");
  }
}

class Perro : Animal  
{
  public override void animalS() 
  {
    Console.WriteLine("El perro hace: bow wow");
  }
}

class Pato : Animal
{
    public override void animalS() 
  {
    Console.WriteLine("El Pato hace: Cuak");
  }
    
}

class Oveja : Animal
{
    public override void animalS() 
  {
    Console.WriteLine("La obeja hace: Beee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal(); 
    Animal myGato = new Gato();
    Animal myPerro = new Perro(); 
    Animal myPato = new Pato();
    Animal myOveja= new Oveja();

    myAnimal.animalS();
    myGato.animalS();
    myPerro.animalS();
    myPato.animalS();
    myOveja.animalS();
  }
}
