﻿using System.Collections;
using newApp.models;

ArrayList psLish = new ArrayList();
for (int i= 0 ; i< 3; i++) 
{
    Person ps =new Person ();
    ps.Nhap();
    psLish.Add(ps);
}
    foreach(Person d in psLish){
        System.Console.WriteLine(d.PersonID + " - " + d.FullName);

    }

