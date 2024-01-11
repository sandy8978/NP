var eggs=[1,2,"nag",4.5,true,"",null];
console.log(eggs);
eggs.push("sai");
console.log(eggs);

console.log(eggs.includes("nag"));
console.log(eggs.fill(1,2));
 console.log(eggs.copyWithin(0,3,6)) 
 console.log(eggs.entries());
 let it=eggs.keys(1);
 console.log(it.next().value)
 console.log(it.next().done)
 let arr=[1,2,3]
 console.log([...arr])
for (let v of eggs)
{
    console.log(v)
}

let a={name:"John",age:30};
Object.defineProperty(a,"gender","writable");
try {
    a.gender="male";
    } catch (error) {
        console.log(`caught an error ${error}`);
        }

