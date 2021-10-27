using System;
using Abstractochinterfaces;

Greeter hello = new FriendlyGreeter();
hello.SayHello();

Book moveBook = new Book();
moveBook.Move(45, 7);

Chair moveChair = new Chair();
moveChair.Move(5, 1);

IImovable[] moveArray = new IImovable[3];
moveArray[0] = new Book();
moveArray[1] = new Chair();
moveArray[2] = new Book();

for (int i = 0; i < moveArray.Length; i++)
{
    moveArray[i].Move(55, 55);
}