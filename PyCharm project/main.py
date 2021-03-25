print("Hello World!")
print("About to learn Python for real!")

# Phép toán cơ bản với hai số nhập vào từ bàn phím

x = int(input("Nhập số x: "))
y = int(input("Nhập số y: "))

print("Phép tính nhân có kết quả là:", x * y)
print("Phép tính chia có kết quả là:", x / y)
print("Phép tính cộng có kết quả là:", x + y)
print("Phép tính trừ có kết quả là:", x - y)
print("Phép tính chia lấy dư có kết quả là:", x % y)
print("Phép tính luỹ thừa có kết quả là:", x ** y)

# Chương trình tính bán kính hình tròn

# r = float(input("Nhập bán kinh: "))
# print("Chu vi hình tròn =", 2 * 3.14 * r)

# Vòng lặp và điều kiện

# i = int(input("Nhập vào số i: "))
# while i < 10:
#     print('I love you')
#     i += 1

# Thuật toán sắp xếp nổi bọt (bubble sort)

testList = [10, 5, 7, 8, 9, 4, 1]
print("Mảng trước khi sắp xếp:")
print(testList)

for i in range(0, len(testList) - 1):
    for j in range(0, len(testList) - 1 - i):
        testList[j], testList[j+1] = testList[j+1], testList[j]
        if testList[j] > testList[j + 1]:
            temp = testList[j]
            testList[j] = testList[j+1]
            testList[j+1] = temp

print("Mảng sau khi sắp xếp:")
print(testList)
