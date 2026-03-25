extends Node

var attack_held := false

func _process(_delta: float) -> void:
	if Input.is_action_just_pressed("attack"):
		attack_held = true
		print("Attack!!")

	if Input.is_action_just_released("attack"):
		attack_held = false
		print("ATTACK RELEASED")

	if attack_held:
		print("ATTACK HELD")
