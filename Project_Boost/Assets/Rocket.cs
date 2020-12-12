using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody _rigidbody;
    AudioSource _thrusterAudio;

    void Start() {
        _rigidbody = GetComponent<Rigidbody>();
        _thrusterAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        ProcessInput();
    }

    private void ProcessInput() {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) {
            _rigidbody.AddRelativeForce(Vector3.up * (_rigidbody.mass * 10));

            if (!_thrusterAudio.isPlaying)
                _thrusterAudio.Play();
        }
        if (!(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))) {
            if (_thrusterAudio.isPlaying)
                _thrusterAudio.Stop();
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(-Vector3.forward);
        }
    }
}
