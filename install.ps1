param($installPath, $toolsPath, $package, $project)

$nlog = $project.ProjectItems.Item("NLog.config")
$nlog.Properties.Item("CopyToOutputDirectory").Value = 2