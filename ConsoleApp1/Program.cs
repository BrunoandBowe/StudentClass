namespace ConsoleApp1

{
    class Driver 
{ 
    
    public static void Main(string[] args )
      {
            Student josh = new Student("josh", "winspear", "w15019640");
            System.Console.WriteLine("The name of this student is " + josh.getName());
            StudentSerializer.SerializeStudent(josh);
         

      }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    } // end of namespace 
} // end of class 
