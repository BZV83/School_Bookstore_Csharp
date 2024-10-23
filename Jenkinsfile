pipeline {
  agent any

  environment {
    DOTNET_CLI_HOME = "${env.WORKSPACE}/.dotnet"
  }

  stages {
    stage('Checkout') {
      steps {
        git 'https://github.com/BZV83/School_Bookstore_Csharp.git'
      }
    }

    stage('Build') {
      steps {
        script {
          sh 'dotnet build --configuration Release'
        }
      }
    }

    stage('Publish') {
      steps {
        script {
          sh 'dotnet publish -c Release'
        }
      }
    }
  }

  post {
    success {
      echo 'Build and Publish succeeded'
    }
    failure {
      echo 'Build or Publish failed'
    }
  }
}
