from pickle import TRUE

def is_armstrong_number(number):
    num_len = len(str(number))
    raised_number = 0
    digit = 0
    while digit < num_len:
        nums = str(number)
        power_equation = int(nums[digit]) ** num_len
        raised_number += power_equation
        digit += 1

    if raised_number == number:
        return True
    else:
        return False

