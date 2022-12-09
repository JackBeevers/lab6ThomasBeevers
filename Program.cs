void StackNoParams () {
int a ;
int b ;
int c ;
int d ;
int e ;
a = 1;
b = 2;
c = 3;
d = 4; 
e = 5; 
 }
StackNoParams();

void StackWithParams (int a2, int b2, int c2){
a2 = 3;
b2 = 4; 
c2 = 5; 
}


void StackWithHeap (int a3, int b3, int c3, string d3){
a3 = 1;
b3 = 2; 
c3 = 3;
d3 = "hello";
int e3 ;
int f3 ;
e3 = 7;
f3 = 10;
string g3; 
g3 = "my name is blake ";
}


void StackOverFlow (){
    int a4 = 100;
    string b4 = "hey man";
    Console.WriteLine (a4 + b4);
    StackOverFlow();
}
StackOverFlow();
