#include <iostream>
 using namespace std;
 
 
 int main(){
 

int runner =0;
int pick;
				while(runner==0){
		
	 cout << "\n";
cout << "----------------------------------" << "\n";
cout << "+___________MAIN MENU____________+" << "\n";
cout << "----------------------------------" << "\n";
cout << "+ [1.] One-Dimentional Array     +" << "\n";
cout << "+ [2.] Multi-Dimentional Array   +" << "\n";
cout << "+ [3.]        E X I T            +" << "\n";
cout << "==================================" << "\n";
cout << " Please select an Operation [1-3]" << "\n";
 cin >> pick;
switch(pick){

	case 1: {
		cout << "\n";
cout <<  "= = = One-Dimentional Array = = =" << "\n";

   int put1;
	 int ray[5];
	int put;
	cout << " Enter # of Elements: ";
	cin >> put;


	for(int exodia=0; exodia<put; exodia++){
		cout << "    " << "[ " << " " << exodia << " " << " ]";
		cin >> ray[exodia];
		}
			cout << "\n";
	        cout << "===================================" << "\n";
			cout << "=        [ 1 ] D E L E T E        =" << "\n";
			cout << "=        [ 2 ] S E A R C H        =" << "\n";
			cout << "=        [ 3 ] U P D A T E        =" << "\n";
			cout << "===================================" << "\n";
			cout << "Enter an Operation [1-3]: ";


	cin >> put1;
	
		switch(put1){

			case 1:{
char pili1;


		 cout << " Enter Index Pos. to Delete: ";
		 int erad;
		cin >> erad;
		int rase=erad;
		while(rase < put){
			ray[rase-1]=ray[rase];
			rase=rase+1;
		}
		put=put-1;
			for(int eyodia=0; eyodia<put; eyodia++){
				cout << "    " << ray[eyodia] << "  ";
						cout << " ";


			}
	cout << "\n";
										cout << "\n";

		break;


 }

		case 2:{
			int ser;
			cout << " Enter # to Search in the Elements: ";
				int find;
				cin >> find;
				ser=0;
				while(ser < put ){
					if(ray[ser]==find){
						break;
					}
					ser=ser+1;
				}
				cout << " The Position of  " << find << "  is  " << ser  << " \n ";
										cout << " \n ";
			break;
		}
			case 3:{
				int upd;
				cout << "Enter # Position to Update: ";
				cin >> upd;
				cout << "Enter #: ";
				int updnum;
				cin >> updnum;
				ray[upd-1]=updnum;
				for(int ewodia=0; ewodia<put; ewodia++){
					cout << ray[ewodia] << " ";

			}
			
			}			
}
	break;
}
	 	




	 case 2: { 	
	 	int put2;
	int ray[2][3];
	int hori,verti;
	 		cout << "\n";
		cout <<  "* * * Multi-Dimentional Array * * *" << "\n";	
	 	
	 	cout<< "Enter # of Row: ";
	cin >> hori;
	cout << "Enter # of Column: ";
	cin >> verti;
	
	for(int exodia=0; exodia<hori; exodia++){
	for (int eyodia=0; eyodia<verti; eyodia++){
		
	cout << "    [ " << exodia << " ]" << "[ " << eyodia << " ]";
 		cin >> ray[exodia][eyodia];

	}		
	}
	 	cout << "\n";
	 		cout << "* * * Multi-Dimentional Array * * *" << "\n";	
	        cout << "***********************************" << "\n";
			cout << "*        [ 1 ] S E A R C H        *" << "\n";
			cout << "*        [ 2 ] U P D A T E        *" << "\n";
	        cout << "***********************************" << "\n";
			cout << "Enter an Operation [1-2]: ";
	 		cin >> put2;
	 		
	 		switch(put2){
	 		case 1:{

	int find;
	cout << " Enter # to Search: ";
	cin >> find;
	

	 
	for(int exodia=0; exodia<hori; exodia++){
	for (int eyodia=0; eyodia<verti; eyodia++){	
	if(ray[exodia][eyodia]==find){
		cout << "  The # " << find << " is in the Pos. of: " << exodia << "   " << eyodia;
			 	cout << "\n";
	}
	}
}
				break;
			 }	
			 
			 
	 		case 2:{
	 			
	 					int repl, rr, cc; 	
	 cout << " Enter # of Row & Column to Update: " << " \n";
	 cout << "  Row: ";
	 cin>>  rr;
	 cout << "  Column: ";
	 cin>> cc;

	 cout << "Enter # to Replace: ";
	  cin >> repl;
	  
	  ray[rr][cc]=repl;
	for(int exodia=0; exodia<hori; exodia++){
		for (int eyodia=0; eyodia<verti; eyodia++){
		cout << ray[exodia][eyodia] << "     ";

}

}
				 cout << "\n";	 			
				break;
			 }
			 	exit(0);		 			
			 }
			 	 		 		 	
		break;

	 }
		
			

	



	 	default:
	 		cout << "Error Operation only [1-3]" << " \n ";
	 		runner = true;
	 		 		cout << " \n ";
	 }
	 cout << "\n";
cout << "Back to the Main Menu? Yes[0] || [1]No ";
		 cin >> runner;

if(runner==0){
		system("cls");
	runner=0;

}else {
    runner=1;
exit(0);
	 
	 
}
}

return 0;
}
