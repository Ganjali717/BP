using BasicExamples;

///Inheritance Chapter 
Stock msft = new Stock();
Asset a = msft; // Upcast
Stock s = (Stock)a; // Downcast