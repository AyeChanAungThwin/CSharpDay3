let I = a => a; //returns as input

let K = a => b => a; //returns first value
let KI = K(I); //returns second value

let T = K;
let F = KI;

let toBool = f => f(true)(false);
           //K    K(true)(false) = true
		   //KI   KI(true)(false) = false

//let Not = f => a => b => f(b)(a); 
let NOT = f => f(F)(T); 

let AND = p => q => p(q)(p);
let OR = p => q => p(T)(q);

let BEQ = p => q => p(q)(NOT(q));

let ZERO = f => a => a;

let ONCE = f => a => f(a);

let TWICE = f => a => f(f(a));

let c = x => x+1;
let toNum = n => n(c)(0);

/*ZERO = f => a => a;
	   f    c

ONCE = f => a => f(a);
       f    c    ZERO*/

//SUCC := λn.λf.λx.f (n f x)
let SUCC = n => f => x => f(n(f)(x));

let THRICE = SUCC(TWICE);

let FOURTH = SUCC(THRICE);