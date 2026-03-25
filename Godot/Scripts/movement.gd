extends Node

@onready var body = get_parent() 

func _physics_process(_delta: float) -> void:
	var move := Input.get_vector("left", "right", "up", "down")
	
	if move != Vector2.ZERO:
		print("MOVE ", move)
		
		var direction = (body.transform.basis * Vector3(move.x, 0, move.y)).normalized()
		body.velocity.x = direction.x * 5.0
		body.velocity.z = direction.z * 5.0
	else:
		body.velocity.x = move_toward(body.velocity.x, 0, 5.0)
		body.velocity.z = move_toward(body.velocity.z, 0, 5.0)

	body.move_and_slide()
