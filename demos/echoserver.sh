#!/usr/bin/env bash
kubectl run hello-suave --image=docker.io/suave/echoserver:latest --port=8002
kubectl expose deployment hello-suave --type=NodePort
kubectl get pod
sleep 5
kubectl get pod
curl $(minikube service hello-suave --url)

# minikube stop
