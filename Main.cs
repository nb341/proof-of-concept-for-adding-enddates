
using System;
using System.Collections.Generic;
using 
System.Linq;
namespace MyApplication
{
    class Person
  {
    public string Name    // property
    {
      get;
      set;
    }  
        public string Id    // property
    {
      get;
      set;
    }  
        public string Method    // property
    {
      get;
      set;
    }
            public string EndDate    // property
    {
      get;
      set;
    }
    
    public override string ToString(){
    		return "name : " + Name + " Id: " + Id + " Method: "+Method + " EndDate: "+EndDate;
    }
    
    public override bool Equals(object obj){
    	if(obj==null) return false;
        Person other = obj as Person;
        return(
        		Name==other.Name && Method==other.Method
                );

    }
 
 
  }
  class Main
  {
    static void Main(string[] args)
    {
      Person myObj = new Person();
      Person myObj2 = new Person();
      Person myObj3 = new Person();
      Person myObj4 = new Person();
      Person myObj5 = new Person();
      Person myObj6 = new Person();
      myObj.Id = "000";
      myObj.Name = "Liam";
      myObj.Method = "1";
    
      myObj2.Name = "Lam";
      myObj2.Id = "000";
      myObj2.Method = "1";
            
      myObj3.Name = "Li";
      myObj3.Id = "100";
      myObj3.Method = "2";
            
      myObj4.Name = "Lm";
      myObj4.Id = "100";
      myObj4.Method = "2";
      
      myObj5.Name = "Neeson";
      myObj5.Id = "200";
      myObj5.Method = "3";
      myObj6.Name = "Conrad";
      myObj6.Id = "300";
      myObj6.Method = "4";
            
      //Console.WriteLine(myObj.Equals(myObj2));
      List<Person> n = new List<Person>();
      List<Person> o = new List<Person>();
      o.Add(myObj);
      n.Add(myObj2);
       o.Add(myObj3);
       n.Add(myObj4);
       o.Add(myObj5);
      n.Add(myObj6);
      int nC = n.Count;
      int oC = o.Count;
      List<string> dd = new List<string>();
      int cnt = 0;
      Console.WriteLine(nC);
      Console.WriteLine(oC);
      for(int i=0; i<oC; i++){
        if(dd.Contains(o[i].Method)) continue;
      	var a = n.FirstOrDefault(c=> c.Method==o[i].Method);
      	
        Console.WriteLine(dd.Contains(o[i].Method));
                
                if(a==null) continue;
       
     
        
        for(int j=0; j<nC; j++){
             cnt++;
        	if(!o[i].Equals(a)){
        	    Console.WriteLine("String n"+(false&&false));
        	    if(!dd.Contains(a.Method) && String.IsNullOrEmpty(a.EndDate)){
        	        dd.Add(o[i].Method);
            	if(j==0){
                o[i].EndDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                	n.Insert(0,o[i] with {Id={a.Id}});
                }else{
                  o[i].EndDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                  n.Insert(j-1,o[i]);
                }
        	    }
            }
     
        }
        
    }

        
        
         Console.WriteLine(cnt);
         
         foreach(var k in n){
             Console.WriteLine(k.ToString()+"\n");
         }
        //Console.WriteLine(string.Join("Old: ", o));
      
      
      
}
  }
}
