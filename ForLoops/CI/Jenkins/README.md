# Jenkins Pipelines
This directory contains the Jenkins pipelines.  The following pipelines are provided.

* `Jenkinsfile` - the Jenkins build pipeline definition for building the AMI
* `Jenkinsfile-DeployToDev` - the Jenkins build pipeline definition for deploying the AMI to dev
* `Jenkinsfile-DeployToCert` - the Jenkins build pipeline definition for deploying the AMI to cert
* `Jenkinsfile-DeployToProd` - the Jenkins build pipeline definition for deploying the AMI to prod
* `Jenkinsfile-RollbackDev` - the Jenkins build pipeline definition for flipping the stack pointed to be the application load balancer in dev
* `Jenkinsfile-RollbackCert` - the Jenkins build pipeline definition for flipping the stack pointed to be the application load balancer in cert
* `Jenkinsfile-RollbackProd` - the Jenkins build pipeline definition for flipping the stack pointed to be the application load balancer in prod
* `Jenkinsfile-OWASP` - the Jenkins build pipeline definition for running OWASP dependency checks

# Usage
The following pipelines should be deployed to [Jenkins](https://opsdev-app-jenkins.route53.lexis.com/) using the Pipeline builds.  The build pipeline must be named `PScore.Service` and each of the other templates must be named `PScore.Service-<PipelineSuffix>` (e.g. `PScore.Service-DeployToDev`).  

The pipelines will auto-configure triggers, log rotation and parameters after they've been run the first time.

The pipelines should all be configured to prevent concurrent builds.

## Build Pipeline
The service includes a Jenkins build pipeline in `Jenkinsfile`.

The pipeline will build, test, package, and bake an AMI for the service.  The initial build artifact is a zip file that contains the published application which is uploaded to [Artifactory](http://opscert-artifactory.route53.lexis.com/artifactory/webapp/#/home).

The pipeline then bakes an immutable AWS AMI which is subsequently deployed to each environment.  The AMI is based on the [RETS CentOS7 Base AMI](https://wiki.regn.net/wiki/RETS_AMIs) which is configured (via Ansible) with [Splunk](http://cdc4c-loganalysis-splunk-searchhead.route53.lexis.com/en-US/app/launcher/home) for log aggregation and [NewRelic](https://rpm.newrelic.com/accounts/1428084/applications/45413450) for application monitoring.  Ansible is then used to deploy the ASP.NET runtime and application code to the AMI.

The generated AMI has support for:
* Joining the Active Directory domain (this allows users with appropriate roles to access the machine)
* [AWS Systems Manager](https://docs.aws.amazon.com/systems-manager/latest/userguide/what-is-systems-manager.html)
* [NewRelic APM](https://newrelic.com/application-monitoring)
* [Splunk Log Management](https://www.splunk.com/)
* [Application Configuration](#Application-Configuration)

## Deploy To Dev Pipeline
The service includes a Jenkins pipeline in `Jenkinsfile-DeployToDev` that will deploy that service to the dev environment.

## Deploy To Cert Pipeline
The service includes a Jenkins pipeline in `Jenkinsfile-DeployToCert` that will deploy that service to the cert environment.

## Deploy To Prod Pipeline
The service includes a Jenkins pipeline in `Jenkinsfile-DeployToProd` that will deploy that service to the prod environment.

## Rollback Dev Pipeline
The service includes a Jenkins pipeline in `Jenkinsfile-RollbackDev` that will simply flip the stack that the dev application load balancer is pointing to.  This will have the effect of making the previous deploy active.  This is designed to be used in an emergency as it is quicker than explicitly pushing a previous build.

## Rollback Cert Pipeline
The service includes a Jenkins pipeline in `Jenkinsfile-RollbackCert` that will simply flip the stack that the cert application load balancer is pointing to.  This will have the effect of making the previous deploy active.  This is designed to be used in an emergency as it is quicker than explicitly pushing a previous build.

## Rollback Prod Pipeline
The service includes a Jenkins pipeline in `Jenkinsfile-RollbackProd` that will simply flip the stack that the prod application load balancer is pointing to.  This will have the effect of making the previous deploy active.  This is designed to be used in an emergency as it is quicker than explicitly pushing a previous build.

## OWASP Pipeline
The service includes a Jenkins build pipeline in `Jenkinsfile-OWASP`.

The pipeline will run the OWASP dependency check plugin.  Suppressions can be configured in the `owasp-suppression.xml` file.
