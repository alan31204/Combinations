using System;
using System.Collections;
using System.Collections.Generic;

//Author: Po-Chun Chiu
//Partner: Yujie Liu
//CSC254 A1 C# Combination

public class Program{
	
   //create a function in which return an integer List of remaining possible choices
  public List<int> left(int prev,int index,int k, int n){
    List<int> list = new List<int>();
    //prev represents the previous selected index, and index means the current index
    //the empty list will consider the elements from prev+1() to n-(k-index) (The possible choices in current index)
    //(k-index) represents that how many possible choices we are going to pick later
    //for example, if we are in index 2 and k is 3, then we still need to choose 1 element after this choice
	for(int i = prev+1; i<=n-(k-index) ; i++) {
		list.Add(i);
	}
	return list;
  }
	//main function for combination
  public void cb(int []a, int current, int k, int n){
	//when find a possible choice of k's choice, print it out
    if(current==k) {
	for(int m=0;m<k;m++) {
		if(m==(k-1)) {
			Console.Write(a[m]);
			Console.WriteLine();
		}else {
			Console.Write(a[m]+" ");
		}
	}
    }
   else {
      List<int> remain = new List<int>();
	if(current==0) {
	//when current is 0, that means we are going to initialize all possible numbers out
	for(int i = 1;i<=n;i++) {
		remain.Add(i);
	}
	}else {
	//use the left function to find possible remaining numbers we can use
	remain=left(a[current-1],current+1, k, n);
	}
	for(int i=0; i < remain.Count;i++) {
	//pick a possible choice and apply recursion to keep finding more choices
	a[current]=remain[i];
	cb(a,current+1, k, n);
	}
  }
 }
	
  static void Main(string[] args){
    int k=int.Parse(args[0]);
    int n=int.Parse(args[1]);
    int[] array=new int[k];
    //initialize a program p and run the cb function
    Program p = new Program();
    p.cb(array,0,k,n);
  }

}

