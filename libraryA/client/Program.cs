using libraryA;

Book book= new Book();
book.Title = "To kill a Mocking Bird";
    book.Author = "Happer lee";
book.Genre = "social";
book.BookPrice = 100;
book.DateofPublish =new DateTime(1995, 05, 01);
book.BookMarkPage(125);
Console.WriteLine( book.Getcurrentpage());
calculator Calculator=new calculator();
int addResult=Calculator. Add(100,40);
Console.WriteLine( addResult);
int multiplyresult = Calculator.multiply(100, 40);
Console.WriteLine( multiplyresult);
int divideresult = Calculator.Divide(100, 40);
Console.WriteLine( divideresult);
    

