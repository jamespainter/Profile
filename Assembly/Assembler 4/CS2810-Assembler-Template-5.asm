TITLE CS2810 Assembler Assignment Template

; Student Name: James Painter
; Assignment Due Date: 12/06/2015

INCLUDE Irvine32.inc
.data
	;--------- Enter Data Here
	vsemester byte "CS2810 Fall Semester 2015",0
	vassembler byte "Assembler Assignment #4",0
	vhexcode byte "Enter Hex Value",0
	vname byte "James Painter",0
	vArray byte "January ",0,"  "
		   byte "February ",0," "
		   byte "March ",0,"    "
		   byte "April ",0,"    "
		   byte "May ",0,"      "
		   byte "June ",0,"     "
		   byte "July ",0,"     "
		   byte "August ",0,"   "
		   byte "September ",0
		   byte "October ",0,"  "
		   byte "November ",0," "
		   byte "December ",0
	
	vSuffixes byte "--stndrdththththththththththththththththstndrdththththththththst",0
	vSuffix byte "--",0
	vComma byte ", ",0
	vYear byte "----",0
	
.code
main PROC
	;--------- Enter Code Below Here
	call clrscr

	;stack
	
	call DisplaySemester
	call DisplayAssignment
	call DisplayName
	call ReadDate
	call RHex
	call Month
	call Day 
	call year
	
	xor ecx, ecx
	call readchar

	exit
	

DisplaySemester:
	;CS2810 Fall Semester 2015
	mov dh, 4 ;row
	mov dl, 33 ;col
	call gotoxy
	mov edx, offset vsemester
	jmp DisplayString
	ret

DisplayAssignment:
	;Assignment4
	mov dh, 5 ;row
	mov dl, 33 ;col
	call gotoxy
	mov edx, offset vassembler
	jmp DisplayString
	ret

DisplayName:
	; name
	mov dh, 6 ;row
	mov dl, 33 ;col
	call gotoxy
	mov edx, offset vname
	jmp DisplayString
	ret

ReadDate:
	;Prompt FAT16 Date
	mov dh, 8 ;row
	mov dl, 33 ;col
	call gotoxy
	mov edx, offset vhexcode
	jmp DisplayString
	ret

RHex:
	mov dh, 9 ;row
	mov dl, 33 ;col
	call gotoxy
	call ReadHex
	ROR AX, 8
	mov ecx, eax
	ret

Month:

									;MOV BH, 10
									;DIV BH
									;ADD AX, 3030h
	
									;mov word ptr [vMonth+0], AX
									;mov dh, 11 ;row
									;mov dl, 33 ;col
									;call gotoxy
									;mov edx, OFFSET vMonth
									;call WriteString
									;mov eax, 2

AND AX, 0000000111100000b
	SHR AX, 5
	
	sub eax,1
	mov dh, 10 ;row
	mov dl, 33 ;col
	call gotoxy
	mov edx, OFFSET [vArray]
	mov bl, 11
	mul bl
	add edx, eax
	mov eax, ecx
	call DisplayString
	ret


Day:


					;seconds
					;AND AX, 0000000000011111b
					;SHL AX, 1
					;MOV BH, 10
					;DIV BH
					;ADD AX, 3030h
					;mov word ptr [vTimeField+6], AX
	
	AND AX, 0000000000011111b
	MOV BH, 10
	DIV BH
	ADD AX, 3030h
	mov word ptr [vSuffix], AX
	mov edx, OFFSET vSuffix
	mov eax, ecx
	call WriteString

	;--------<Suffix Code>----------
    AND AX, 0000000000011111b
	shl eax, 1
	mov edx, offset[vSuffixes]
	add edx, eax
	mov bx, word ptr [edx]
	mov word ptr [vSuffix], bx
	mov edx, offset [vSuffix]
	call DisplayString
	mov edx, offset vComma
	call DisplayString
	mov eax, ecx
	
	
ret

Year: 
xor dx, dx
AND AX, 1111111000000000b
	shr ax, 9
	add ax, 1980
	mov bx, 1000 
	div bx
	add al, 30h 
	mov byte ptr [vYear], al
	
	 mov ax, dx
	 xor dx, dx
	 mov bx, 100
	 div bx
	 add al, 30h 
 	 mov byte ptr [vYear+1], al

	 mov ax, dx
	 xor dx, dx
	 mov bx, 10
	 div bx
	 add al, 30h 
 	 mov byte ptr [vYear+2], al

	 mov ax, dx
	 xor dx, dx
	 mov bx, 1
	 div bx
	 add al, 30h 
 	 mov byte ptr [vYear+3], al

	 mov edx, offset vYear
	 call DisplayString

ret


DisplayString:
	call WriteString
ret

	
main ENDP

END main