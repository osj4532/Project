	MOV BX, DATA2
	MOV BL, DATA1
	MOV DATA2, BX
	MOV DATA1, BL
	MOV BX, CX
	MOV BL, CL
	MOV DATA1, 11
	MOV DATA2, 11
	MOV BX, 11
	MOV BL, 11
	MOV DS, BX
	ADD BX, DATA2
	ADD BL, DATA1
	ADD DATA2, BX
	ADD DATA1, BL
	ADD BX, CX
	ADD BL, CL
	ADD DATA1, 11
	ADD DATA2, 11
	ADD BX, 11
	ADD BL, 11
	ADD DS, BX
	SUB BX, DATA2
	SUB BL, DATA1
	SUB DATA2, BX
	SUB DATA1, BL
	SUB BX, CX
	SUB BL, CL
	SUB DATA1, 11
	SUB DATA2, 11
	SUB BX, 11
	SUB BL, 11
DATA1 DB 9
DATA2 DW 10
