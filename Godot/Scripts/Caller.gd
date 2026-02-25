extends Node

@export var receiver: Node

func _ready():
	print("Hello Friend")
	receiver.OnCalled()
