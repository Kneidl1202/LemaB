from tkinter.filedialog import *
import save_in_excel


def read_files():
    path = askdirectory()
    amount_path = path + '/amount.txt'
    seite1_path = path + '/seite1.txt'
    seite2checkboxes_path = path + '/seite2checkboxes.txt'
    seite2textboxes_path = path + '/seite2textboxes.txt'
    seite3_path = path + '/seite3.txt'
    seite4_path = path + '/seite4.txt'
    seite5_path = path + '/seite5.txt'
    seite6_path = path + '/seite6.txt'
    paths = [amount_path, seite1_path, seite2checkboxes_path, seite2textboxes_path, seite3_path, seite4_path,
             seite5_path, seite6_path]

    read_stuff = {}
    for item in paths:
        temp_path = item[len(path) + 1:-4]

        with open(item) as file:
            read_stuff[temp_path] = (file.read())
            file.close()

    return read_stuff


def split_read_stuff(read_stuff):
    seite1 = []
    seite2checkboxes = []
    seite2textboxes = []
    seite3 = []
    seite4 = []
    seite5 = []
    seite6 = []

    for i in range(int(read_stuff['amount']) + 1):
        seite1.append([])
        seite2checkboxes.append([])
        seite2textboxes.append([])
        seite3.append([])
        seite4.append([])
        seite5.append([])
        seite6.append([])

    i = 0
    j = 0
    for item in read_stuff['seite1'].split('\n'):
        if j == 8:
            j = 0
            i += 1
        seite1[i].append(item)
        j += 1

    i = 0
    j = 0
    for item in read_stuff['seite2checkboxes'].split('\n'):
        if j == 8:
            j = 0
            i += 1
        seite2checkboxes[i].append(item)
        j += 1

    i = 0
    j = 0
    for item in read_stuff['seite2textboxes'].split('\n'):
        if j == 18:
            j = 0
            i += 1
        seite2textboxes[i].append(item)
        j += 1

    i = 0
    j = 0
    for item in read_stuff['seite3'].split('\n'):
        if j == 30:
            j = 0
            i += 1
        seite3[i].append(item)
        j += 1

    i = 0
    j = 0
    for item in read_stuff['seite4'].split('\n'):
        if j == 14:
            j = 0
            i += 1
        seite4[i].append(item)
        j += 1

    i = 0
    j = 0
    for item in read_stuff['seite5'].split('\n'):
        if j == 180:
            j = 0
            i += 1
        seite5[i].append(item)
        j += 1

    i = 0
    j = 0
    for item in read_stuff['seite6'].split('\n'):
        if j == 9:
            j = 0
            i += 1
        seite6[i].append(item)
        j += 1



    return [int(read_stuff['amount']) + 1, seite1, seite2checkboxes, seite2textboxes, seite3, seite4, seite5, seite6]


def delete_last_item_from_each_file(read_stuff):
    for item in read_stuff:
        if item != 'amount':
            temp = read_stuff[item]
            temp = temp[0:-1]
            read_stuff[item] = temp

    return read_stuff


if __name__ == '__main__':
    read_data = read_files()  # read the stuff written in the files
    read_data = delete_last_item_from_each_file(read_data)  # delete the last element in every dict key cause a bug
    split_data = split_read_stuff(read_data)  # split the read stuff into final arrays

    print(split_data)
    save_in_excel.main(split_data)
