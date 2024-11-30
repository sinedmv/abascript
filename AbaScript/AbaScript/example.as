# Объявление переменных и массива
var x = 10;
var y = 5;
var numbers[5];

# Ввод значения для переменной y
input(y);

# Присваивание значений элементам массива
numbers[0] = x;
numbers[1] = y;
numbers[2] = x + y;
numbers[3] = numbers[0] * 2;
numbers[4] = numbers[1] - 3;

print(numbers[0]);
print(numbers[1]);
print(numbers[2]);
print(numbers[3]);
print(numbers[4]);

if (x > y) {
    print("x больше y");
} elif (x == y) {
    print("x равно y");
} else {
    print("x меньше y");
}

# Цикл while
    var i = 0;
while (i < 5) {
    print(numbers[i]);
    i = i + 1;
}

# Определение и вызов функции
func add(a, b) {
    return a + b;
}

var result = add(x, y);
print(result);

func factorial(n)
{
    if (n == 1 || n == 0) {
        return 1;
    }
    return n * factorial(n - 1);
}

print(factorial(5));