pipeline {
  agent any
  
  stages {

    stage('Checkout') {
      steps {
        git 'https://github.com/BZV83/School_Bookstore_Csharp.git'
      }
    }
    
    stage('Potato') {
      steps {
        script {
          sh '''
          echo "you are a potato"
          '''
        }
      }
    }

    stage('Build') {
      steps {
        script {
          sh 'dotnet build Bookstore_Mission_11_Vick.sln -c Release'
        }
      }
    }

    stage('Publish') {
      steps {
        script {
          sh 'dotnet publish Bookstore_Mission_11_Vick.csproj -c Release'
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
