import xlsxwriter

def fill_excel_file(data, worksheet, workbook):
    amount = data[0]

    green = workbook.add_format({'fg_color': 'green', 'border': 1})
    yellow = workbook.add_format({'fg_color': 'yellow', 'border': 1})
    red = workbook.add_format({'fg_color': 'red', 'border': 1})

    for i in range(int(amount)):
        split1 = []
        split2 = []
        split3 = []
        split4 = []
        split5 = []
        split6 = []
        split7 = []

        for item in data[1][i]:
            split1.append(item)

        for item in data[2][i]:
            split2.append(item)

        for item in data[3][i]:
            split3.append(item)

        for item in data[4][i]:
            split4.append(item)

        for item in data[5][i]:
            split5.append(item)

        for item in data[6][i]:
            split6.append(item)

        for item in data[7][i]:
            split7.append(item)

        # names
        worksheet.write(2, 1 + i, split1[2])

        # 1 mehr
        if split2[0] == '-' and split2[2] == "1-":
            worksheet.write(5, i + 1, "", green)
        elif split2[2] == "1--" or split3[0] != "":
            worksheet.write(5, i + 1, "", red)
        else:
            worksheet.write(5, i + 1, "", yellow)

        if split2[0] == '-' and split2[3] == "2-":
            worksheet.write(6, i + 1, "", green)
        elif split2[3] == "2--" or split3[1] != "":
            worksheet.write(6, i + 1, "", red)
        else:
            worksheet.write(6, i + 1, "", yellow)

        if split2[0] == '-' and split2[4] == "3-":
            worksheet.write(7, i + 1, "", green)
        elif split2[4] == "3--" or split3[3] != "":
            worksheet.write(7, i + 1, "", red)
        else:
            worksheet.write(7, i + 1, "", yellow)

        # 1 weniger
        if split2[1] == '---' and split2[5] == "4-":
            worksheet.write(9, i + 1, "", green)
        elif split2[5] == "4--" or split3[2] != "":
            worksheet.write(9, i + 1, "", red)
        else:
            worksheet.write(9, i + 1, "", yellow)

        if split2[1] == '---' and split2[6] == "5-":
            worksheet.write(10, i + 1, "", green)
        elif split2[6] == "5--" or split3[4] != "":
            worksheet.write(10, i + 1, "", red)
        else:
            worksheet.write(10, i + 1, "", yellow)

        if split2[1] == '---' and split2[7] == "6-":
            worksheet.write(11, i + 1, "", green)
        elif split2[7] == "6--" or split3[5] != "":
            worksheet.write(11, i + 1, "", red)
        else:
            worksheet.write(11, i + 1, "", yellow)

        # 2. Zahlwortreihe
        for j in range(6):
            if split4[j] == "auto":
                worksheet.write(13 + j, i + 1, "", green)
            elif split4[j] == "nicht" or split4[j + 18] != "" or split4[j + 24] != "":
                worksheet.write(13 + j, i + 1, "", red)
            else:
                worksheet.write(13 + j, i + 1, "", yellow)

        if split4[9] != "":
            worksheet.write(16, i + 1, "", green)

        # 3. Operationsverstaendnis //4 + 5
        for j in range(5):
            if split5[j] == "ja":
                worksheet.write(21 + j, i + 1, "", green)
            else:
                worksheet.write(21 + j, i + 1, "", red)

        # //7 - 3
        for j in range(5):
            if split5[j] == "ja":
                worksheet.write(j + 30, i + 1, "", green)
            else:
                worksheet.write(j + 30, i + 1, "", red)

        # 4. Plus und minus im Zahlenraum 10
        l = 0
        for j in range(10):
            for k in range(15):
                if l < 5:
                    if split6[30 + k + j * 15] == "true" and split6[15 + k] == "":
                        worksheet.write(36 + k, i + 1, "", green)
                    elif split6[30 + k + j * 15] == "true" and split6[15 + k] != "":
                        worksheet.write(36 + k, i + 1, "", yellow)
                elif l == 5:
                    if split6[30 + k + j * 15] == "true":
                        worksheet.write(36 + k, i + 1, "", yellow)
                else:
                    if split6[30 + k + j * 15] == "true":
                        worksheet.write(36 + k, i + 1, "", red)
            l += 1

        #5. Sachrechnen
        for j in range(6):
            if j < 2:
                if split7[j] == "ja":
                    worksheet.write(j + 53, i + 1, "", green)
                else:
                    worksheet.write(j + 53, i + 1, "", red)
            elif j < 4:
                if split7[j] == "ja":
                    worksheet.write(j + 54, i + 1, "", green)
                else:
                    worksheet.write(j + 54, i + 1, "", red)
            else:
                if split7[j] == "ja":
                    worksheet.write(j + 55, i + 1, "", green)
                else:
                    worksheet.write(j + 55, i + 1, "", red)



def main(data):
    grade = "1."
    workbook = xlsxwriter.Workbook('C:/Users/Andreas/Desktop/LemaB.xlsx')
    worksheet = workbook.add_worksheet()

    bold = workbook.add_format({'bold': 1, 'align': 'center', 'valign': 'vcenter'})
    bold_border = workbook.add_format({'bold': 1, 'border': 1, 'align': 'center', 'valign': 'vcenter'})
    border = workbook.add_format({'border': 1, 'align': 'right'})
    align = workbook.add_format({'align': 'center', 'valign': 'vcenter'})

    merge_bold_white = workbook.add_format({
        'bold': 1,
        'align': 'center',
        'valign': 'vcenter'
    })

    merge_bold_grey = workbook.add_format({
        'bold': 1,
        'align': 'center',
        'valign': 'vcenter',
        'fg_color': '#E8E8E8',
        'border': 1
    })

    merge_grey = workbook.add_format({
        'align': 'center',
        'valign': 'vcenter',
        'fg_color': '#E8E8E8',
        'border': 1
    })

    merge_green = workbook.add_format({
        'align': 'center',
        'valign': 'vcenter',
        'fg_color': 'green'
    })

    merge_yellow = workbook.add_format({
        'align': 'center',
        'valign': 'vcenter',
        'fg_color': 'yellow'
    })

    merge_red = workbook.add_format({
        'align': 'center',
        'valign': 'vcenter',
        'fg_color': 'red'
    })

    # merge initial rows
    worksheet.merge_range('A1:O1', 'Lernentwichlungsbogen: Mathematische Kompetenzen in der Schuleingangsphase',
                          merge_bold_white)
    worksheet.merge_range('P1:U1', 'Anforderungsstufe', merge_bold_white)
    worksheet.merge_range('A4:U4', '1. Zahlwortreihe', merge_bold_grey)
    worksheet.merge_range('A5:U5', '1 mehr', merge_grey)
    worksheet.merge_range('A9:U9', '1 weniger', merge_grey)
    worksheet.merge_range('A13:U13', '2. Zahlen zerlegen', merge_bold_grey)
    worksheet.merge_range('A20:U20', '3. Operationsverstaendnis', merge_bold_grey)
    worksheet.merge_range('A21:U21', '4+5', merge_grey)
    worksheet.merge_range('A29:U29', '3. Operationsverstaendnis', merge_bold_grey)
    worksheet.merge_range('A30:U30', '7 - 3', merge_grey)
    worksheet.merge_range('A36:U36', '4. Plus und minus im Zahlenraum 10', merge_bold_grey)
    worksheet.merge_range('A52:U52', '5. Sachrechnen', merge_bold_grey)
    worksheet.merge_range('A53:U53', 'Mutti kauft 10 Eier', merge_grey)
    worksheet.merge_range('A56:U56', 'Leon ist 7 Jahre alt', merge_grey)
    worksheet.merge_range('A59:U59', 'Bei Unklarheit: Zwei Steckwuerfeltuerme, einer mit 7, einer mit 4 Wuerfeln',
                          merge_grey)
    worksheet.merge_range('P2:Q2', 'gesichterte\nKenntnisse', merge_green)
    worksheet.merge_range('R2:S2', 'Anfaenge', merge_yellow)
    worksheet.merge_range('T2:U2', 'kaum\nKenntnisse', merge_red)
    worksheet.merge_range('B2:E2', 'Klasse: ' + grade, align)

    # write initial words
    worksheet.write('A2', 'LeMa B', bold)
    worksheet.write('A3', 'Name', bold_border)

    worksheet.write('A6', '7, 1 mehr', border)
    worksheet.write('A7', '12, 1 mehr', border)
    worksheet.write('A8', '16, 1 mehr', border)

    worksheet.write('A10', '9, 1 weniger', border)
    worksheet.write('A11', '12, 1 weniger', border)
    worksheet.write('A12', '16, 1 weniger', border)

    worksheet.write('A14', '5=2+?', border)
    worksheet.write('A15', '8=3+?', border)
    worksheet.write('A16', '9=4+?', border)
    worksheet.write('A17', '7=3+?', border)
    worksheet.write('A18', '6=3+?', border)
    worksheet.write('A19', '9=1+?', border)

    worksheet.write('A22', 'Darsellung passend', border)
    worksheet.write('A23', 'handl.sprachl.begl.', border)
    worksheet.write('A24', 'passende Geschichte', border)
    worksheet.write('A25', 'passende Frage', border)
    worksheet.write('A26', 'Ergebnis korrekt', border)

    worksheet.write('A31', 'Darstellung passend', border)
    worksheet.write('A32', 'Handl.sprachl.begl.', border)
    worksheet.write('A33', 'passende Geschichte', border)
    worksheet.write('A34', 'passende Frage', border)
    worksheet.write('A35', 'Ergebnis korrekt', border)

    worksheet.write('A37', '3 + 3', border)
    worksheet.write('A38', '3 + 4', border)
    worksheet.write('A39', '4 + 6', border)
    worksheet.write('A40', '8 - 5', border)
    worksheet.write('A41', '1 + 6', border)
    worksheet.write('A42', '9 - 8', border)
    worksheet.write('A43', '4 + 4', border)
    worksheet.write('A44', '8 - 4', border)
    worksheet.write('A45', '3 + 6', border)
    worksheet.write('A46', '2 + 7', border)
    worksheet.write('A47', '6 - 3', border)
    worksheet.write('A48', '5 + 4', border)
    worksheet.write('A49', '9 - 4', border)
    worksheet.write('A50', '3 + 7', border)
    worksheet.write('A51', '10 - 5', border)

    worksheet.write('A54', 'Operation erkannt', border)
    worksheet.write('A55', 'Ergebnis korrekt', border)

    worksheet.write('A57', 'Operation erkannt', border)
    worksheet.write('A58', 'Ergebnis korrekt', border)

    worksheet.write('A60', 'Operation erkannt', border)
    worksheet.write('A61', 'Ergebnis korrekt', border)

    # set column and row size
    worksheet.set_column('B:U', 4.43)
    worksheet.set_column('A:A', 19)

    worksheet.set_row(0, 18)
    worksheet.set_row(1, 33)
    worksheet.set_row(2, 73.5)

    for i in range(3, 63):
        worksheet.set_row(i, 15)

    for i in range(1, 21):
        worksheet.write(2, i, "", border)

    for i in range(3):
        for j in range(1, 21):
            worksheet.write(i + 5, j, "", border)

    for i in range(3):
        for j in range(1, 21):
            worksheet.write(i + 9, j, "", border)

    for i in range(6):
        for j in range(1, 21):
            worksheet.write(i + 13, j, "", border)

    for i in range(5):
        for j in range(1, 21):
            worksheet.write(i + 21, j, "", border)

    for i in range(5):
        for j in range(1, 21):
            worksheet.write(i + 30, j, "", border)

    for i in range(15):
        for j in range(1, 21):
            worksheet.write(i + 36, j, "", border)

    for i in range(2):
        for j in range(1, 21):
            worksheet.write(i + 53, j, "", border)

    for i in range(2):
        for j in range(1, 21):
            worksheet.write(i + 56, j, "", border)

    for i in range(2):
        for j in range(1, 21):
            worksheet.write(i + 59, j, "", border)

    fill_excel_file(data, worksheet, workbook)
    worksheet.set_landscape()
    workbook.close()
