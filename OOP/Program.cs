using OOPencapsulation.encapsulation;
// created object from bank class
Bank XalqBanki = new Bank();

// sent to balance 2000 value throw the way encapsulation
XalqBanki.AccessBalance = 2000;

// gotten value of balance from Bank class using the way encapsulation
Console.WriteLine(XalqBanki.AccessBalance);

