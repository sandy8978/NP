class Shape {
    constructor(length, breadth, height) {
        this.length = length;
        this.breadth = breadth;
        this.height = height;
    }

    area() {
        return (this.length * this.breadth * this.height);
    }
}

let obj = new Shape(2, 4, 8);

console.log(obj.area());