import java.util.ArrayList;
import java.util.List;

public class Comb {
	int n;
	int k;
	public Comb(int n, int k){
		this.n=n;
		this.k=k;
	}
	
	//left method calculates that given the previous number chosen and the current index,
	//find the possible choices of pick we can use
	public ArrayList<Integer> left(int prev,int index){
		ArrayList<Integer> list = new ArrayList<Integer>();
		//the empty list will consider the elements from prev+1 to n-(k-index)
		//(k-index) means that how many possible choices we are going to pick later
		//for ex, if we are in index 2 and k is 3, then we still need to choose 1 element after this choice
		for(int i = prev+1; i<=n-(k-index) ; i++) {
			list.add(i);
		}
		return list;
	}
	
	//a[] means the temporary array that's changing and current is the index
	public void cb(int a[],int current) {
		//if the length matches size k, we can print the result out
		if(current==k) {
			for(int m=0;m<k;m++) {
				if(m==(k-1)) {
					System.out.print(a[m]);
					System.out.println();
				}else {
					System.out.print(a[m]+" ");
				}
			}
		}
		else {
			ArrayList<Integer> remain=new ArrayList<Integer>();
			if(current==0) {
				//when current is 0, that means we are going to initialize all possible numbers out
				for(int i =1;i<=n;i++) {
					remain.add(i);
				}
			}else {
				//use the left method to find possible remaining numbers we can use
				remain=left(a[current-1],current+1);	
			}
			
			for(int i=0; i < remain.size();i++) {
				//pick a possible number and use recursion to keep finding more choices
				a[current]=remain.get(i);
				cb(a,current+1);
			}
		}
	}
	
	public static void main(String argv[]) {
		int k =Integer.parseInt(argv[0]);
		int n =Integer.parseInt(argv[1]);
		int array[]=new int[k];
		Comb c=new Comb(n,k);
		c.cb(array,0);
	}
}
