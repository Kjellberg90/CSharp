using System;
using Arv;

MyDerivedClass z = new MyDerivedClass();
z.baseAdd();

MyDerivedClass2 z1 = new MyDerivedClass2(5.7);
z1.baseAdd();

MyBaseClass x = new MyDerivedClass();
MyBaseClass y = new MyBaseClass(3.6);

x.baseAdd();
y.baseAdd();

MyBaseClass[] xarray = new MyBaseClass[3];
xarray[0] = new MyBaseClass(3.4);
xarray[1] = new MyDerivedClass();
xarray[2] = new MyBaseClass(6.7);

foreach (MyBaseClass item in xarray)
{
    if (item.GetType() == typeof(MyDerivedClass) ) 
    {
        MyDerivedClass x = (MyDerivedClass)item;
        x.DerivedMessage();
    }
}