workflow PingUrlParallel {

  param(
    [string]$url,
    [int]$parallelCount = 12,
    [int]$iterations = 100
  )

  foreach -parallel ($x in 1..$parallelCount) {
    1..$iterations | %{ 
        $response = curl $url
        $status = $response.StatusCode
        $response.RawContent
        "worker $x : iteration $_ : $status"
        [System.Threading.Thread]::Sleep(500)
    }
  }
}

# Replace the param with URL of your choice
PingUrlParallel http://novinodev2:8972/api/values